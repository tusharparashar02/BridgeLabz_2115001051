using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
namespace JSON_DataHandling
{
    class ValidateEmailSchema
    {
        public static void ValidateEmail()
        {
            string schemaJson = @"{
            'type': 'object',
            'properties': {
                'email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['email']
            }";

            JSchema schema = JSchema.Parse(schemaJson);
            string json = "{ \"email\": \"tushar@123.com\" }";
            JObject obj = JObject.Parse(json);

            IList<string> errors;
            bool isValid = obj.IsValid(schema, out errors);

            Console.WriteLine($"Is Email Valid? {isValid}");
            if (!isValid) foreach (var error in errors) Console.WriteLine(error);
        }
    }
}
