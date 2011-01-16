using System;


using Google.Apis.Discovery;
using Google.Apis.Json;

using Google.Apis.Tests.Apis.Discovery.V0_3;

namespace PlayAround
{
    class Program
    {
        private const string TestVersion = "TestVersion";
        private const string TestName = "TestName";

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                new Program().SchemaTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("All Done");
            Console.ReadLine();

        }

        public void SchemaTest()
        {
            var service = CreateService();
            Console.WriteLine(service.Schemas.Count);
        }

        private ServiceV0_3 CreateService()
        {
            var param = new FactoryParameterV0_3()
            {
                ServerUrl = "http://server/"
            };
            var json = (JsonDictionary)JsonReader.Parse(ServiceFactoryImplTest.BuzzV0_3_Json);
            return new ServiceV0_3(TestVersion, TestName, param, json);
        }
    }
}

