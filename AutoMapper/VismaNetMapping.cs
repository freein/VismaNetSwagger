using AutoMapper;
using VismaNetSwaggerTest.Models;

namespace VismaNetSwagger.AutoMapper
{
    /// <summary>
    /// This class requires the NuGet package AutoMapper.
    /// </summary>
    public static class VismaNetMapping
    {
        private static void CreateObjectMaps()
        {
            Mapper.CreateMap<CustomerDto, CustomerUpdateDto>()
                .ForMember(x => x.OverrideWithClassValues, y => y.Ignore())
                .ForMember(x => x.Number, y => y.Ignore());

            Mapper.CreateMap<AddressDto, AddressUpdateDto>()
                .ForMember(x => x.CountryId, y => y.MapFrom(v => v.Country.ID))
                .ForMember(x => x.County, y => y.MapFrom(v => v.County.ID));

            Mapper.CreateMap<ContactInfoDto, ContactInfoUpdateDto>();
        }

        private static void CreateDtoValueMaps()
        {
            Mapper.CreateMap<string, DtoValueString>().ConvertUsing<DtoValueStringConverter>();
            Mapper.CreateMap<string, DtoValueCreditRule>().ConvertUsing<DtoValueCreditRuleConverter>();
            Mapper.CreateMap<string, DtoValueStatementTypes>().ConvertUsing<DtoValueStatementTypesConverter>();
            Mapper.CreateMap<string, DtoValueCustomerStatus>().ConvertUsing<DtoValueCustomerStatusConverter>();

            Mapper.CreateMap<int, DtoValueInt32>().ConvertUsing<DtoValueInt32Converter>();
            Mapper.CreateMap<int, DtoValueNullableInt32>().ConvertUsing<DtoValueNullableInt32Converter>();
            Mapper.CreateMap<int, DtoValueNullableInt16>().ConvertUsing<DtoValueNullableInt16Converter>();
            Mapper.CreateMap<AddressDto, DtoValueAddressUpdateDto>().ConvertUsing<DtoValueAddressUpdateConverter>();
            Mapper.CreateMap<ContactInfoDto, DtoValueContactInfoUpdateDto>()
                .ConvertUsing<DtoValueContactInfoUpdateConverter>();
            Mapper.CreateMap<CountyDto, DtoValueString>().ConvertUsing<DtoValueCountyStringConverter>();
            Mapper.CreateMap<CountryDto, DtoValueString>().ConvertUsing<DtoValueCounrtyStringConverter>();
            Mapper.CreateMap<bool, DtoValueBoolean>().ConvertUsing<DtoValueBooleanConverter>();

            Mapper.CreateMap<double, DtoValueDecimal>().ConvertUsing<DtoValueDecimalConverter>();
        }

        public static void CreateMaps()
        {
            CreateDtoValueMaps();
            CreateObjectMaps();
            Mapper.AssertConfigurationIsValid();
        }
    }
    internal class DtoValueDecimalConverter : ITypeConverter<double, DtoValueDecimal>
    {
        public DtoValueDecimal Convert(ResolutionContext context)
        {
            return new DtoValueDecimal
            {
                Value = System.Convert.ToDouble(context.SourceValue)
            };
        }
    }

    internal class DtoValueNullableInt16Converter : ITypeConverter<int, DtoValueNullableInt16>
    {
        public DtoValueNullableInt16 Convert(ResolutionContext context)
        {
            return new DtoValueNullableInt16
            {
                Value = (int?)context.SourceValue
            };
        }
    }

    internal class DtoValueNullableInt32Converter : ITypeConverter<int, DtoValueNullableInt32>
    {
        public DtoValueNullableInt32 Convert(ResolutionContext context)
        {
            return new DtoValueNullableInt32
            {
                Value = (int?)context.SourceValue
            };
        }
    }

    internal class DtoValueInt32Converter : ITypeConverter<int, DtoValueInt32>
    {
        public DtoValueInt32 Convert(ResolutionContext context)
        {
            return new DtoValueInt32
            {
                Value = (int)context.SourceValue
            };
        }
    }


    internal class DtoValueBooleanConverter : ITypeConverter<bool, DtoValueBoolean>
    {
        public DtoValueBoolean Convert(ResolutionContext context)
        {
            return new DtoValueBoolean
            {
                Value = (bool)context.SourceValue
            };
        }
    }


    internal class DtoValueCustomerStatusConverter : ITypeConverter<string, DtoValueCustomerStatus>
    {
        public DtoValueCustomerStatus Convert(ResolutionContext context)
        {
            return new DtoValueCustomerStatus
            {
                Value = (string)context.SourceValue
            };
        }
    }

    internal class DtoValueStatementTypesConverter : ITypeConverter<string, DtoValueStatementTypes>
    {
        public DtoValueStatementTypes Convert(ResolutionContext context)
        {
            return new DtoValueStatementTypes
            {
                Value = (string)context.SourceValue
            };
        }
    }


    public class DtoValueCounrtyStringConverter : ITypeConverter<CountryDto, DtoValueString>
    {
        public DtoValueString Convert(ResolutionContext context)
        {
            var ctx = (CountryDto)context.SourceValue;
            return new DtoValueString
            {
                Value = ctx.ID
            };
        }
    }

    public class DtoValueCountyStringConverter : ITypeConverter<CountyDto, DtoValueString>
    {
        public DtoValueString Convert(ResolutionContext context)
        {
            var ctx = (CountyDto)context.SourceValue;
            return new DtoValueString
            {
                Value = ctx.ID
            };
        }
    }


    public class DtoValueContactInfoUpdateConverter : ITypeConverter<ContactInfoDto, DtoValueContactInfoUpdateDto>
    {
        public DtoValueContactInfoUpdateDto Convert(ResolutionContext context)
        {
            var ctx = (ContactInfoDto)context.SourceValue;
            return new DtoValueContactInfoUpdateDto
            {
                Value = Mapper.Map<ContactInfoDto, ContactInfoUpdateDto>(ctx)
            };
        }
    }

    public class DtoValueAddressUpdateConverter : ITypeConverter<AddressDto, DtoValueAddressUpdateDto>
    {
        public DtoValueAddressUpdateDto Convert(ResolutionContext context)
        {
            var ctx = (AddressDto)context.SourceValue;
            return new DtoValueAddressUpdateDto
            {
                Value = Mapper.Map<AddressDto, AddressUpdateDto>(ctx)
            };
        }
    }

    public class DtoValueStringConverter : ITypeConverter<string, DtoValueString>
    {
        public DtoValueString Convert(ResolutionContext context)
        {
            return new DtoValueString
            {
                Value = (string)context.SourceValue
            };
        }
    }


    public class DtoValueCreditRuleConverter : ITypeConverter<string, DtoValueCreditRule>
    {
        public DtoValueCreditRule Convert(ResolutionContext context)
        {
            return new DtoValueCreditRule
            {
                Value = (string)context.SourceValue
            };
        }
    }
}