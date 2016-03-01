# AutoMapper for Visma.net Swagger

Utilize AutoMapper in order easily convert from EntityDto to EntityUpdateDto. Just add VismaNetMapping.cs to your project and install the NuGet package AutoMapper.

```csharp
VismaNetMapping.CreateMaps();
var vismaNet = new VismanetAPI(uri, credentials, delegationHandler);
var customer = vismaNet.Customer.Get("20086");
customer.Name = "Change Name On Customer";
vismaNet.Customer.Put(customer.Number, Mapper.Map<CustomerUpdateDto>(customer));
```
