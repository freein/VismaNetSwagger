var request = require("request");
var fs = require("fs");

request('https://integration.acc.test.visma.net/API-index/doc/swagger', function (error, response, body) {
  if (!error && response.statusCode == 200) {
    var regex = /"name" : "([0-9a-zA-Z]+)?Paramete?rs\./gi;
    var fixed = body.replace(regex, '"name" : "');
    var json = JSON.parse(fixed);

    var missingDefinitions = [
      "ConfirmShipmentActionDto",
      "ReleaseInvoiceActionDto",
      "ReleaseSupplierInvoiceActionDto",
      "ReleaseSupplierInvoiceActionDto"
    ];

    for(var key in missingDefinitions){
      var def = missingDefinitions[key];
      json["definitions"][def] = {};
    }
    json["definitions"]["Object"] = { "type": "object" };

    var paths = json["paths"];
    for(var key in paths){
      var path = paths[key];
      if(path.put){
        json["paths"][key].put.responses["204"] = {
          "description": "No Content -> OK",
          "schema": {
            "$ref": "#/definitions/Object"
          }
        };
      }
      if(path.post){
        json["paths"][key].post.responses["201"] = {
          "description": "Created -> OK",
          "schema": {
            "$ref": "#/definitions/Object"
          }
        };
      }
    }

    json["paths"]["/controller/api/v1/dimension/{dimensionId}/{segmentId}/{valueId}"]["get"]["operationId"] = "Dimension_GetSegmentValue1"
    json["paths"]["/security/api/v1/testconnection"]["get"]["produces"] = ["application/json"];
    json["paths"]["/security/api/v1/token"]["delete"]["consumes"] = [ "application/json", "application/xml" ];
    json["paths"]["/security/api/v1/token/usercontexts"]["get"]["consumes"] =  [ "application/json", "application/xml" ];

    var stringified = JSON.stringify(json, null, ' ');
    fs.writeFile("swagger.json", stringified, function(error){
      if(error){
        console.log(error)
      } else {
        console.log("swagger.json generated")
      }
    });
  }
});
