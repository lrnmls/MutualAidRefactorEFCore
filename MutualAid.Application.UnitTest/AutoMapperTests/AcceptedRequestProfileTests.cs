using AutoMapper;
using MutualAid.Application.MappingProfiles;
using MutualAid.Data.DTO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MutualAid.Application.UnitTest.AutoMapperTests
{
    public class AcceptedRequestProfileTests
    {
        [Test]
        public void AutoMapper_Configuration_IsValid()
        {
            var acceptedRequest = new AcceptedRequestMappingProfile();
            var mappingConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(acceptedRequest);
            });
            mappingConfig.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapper_ConvertFrom_AcceptedRequest_IsValid()
        {
            var entity = MockDataHelper.GetAcceptedRequestMock();
            var acceptedRequest = new AcceptedRequestMappingProfile();
            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(acceptedRequest);
            });
            mapperConfig.AssertConfigurationIsValid();

            var mapper = new Mapper(mapperConfig);
            var dto = mapper.Map<AcceptedRequestDto>(entity);

            Assert.IsNotNull(dto);
            Assert.IsInstanceOf<AcceptedRequestDto>(dto);
            Assert.IsTrue(dto.RequestId == entity.RequestId);
        }
    }
}
