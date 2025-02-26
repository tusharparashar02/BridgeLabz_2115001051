using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JSON_DataHandling
{
    class ValidateJSONstruc
    {
            public static void Validate()
            {
                string schemaJson = @"{
                    'type': 'object',
                    'properties': {
                        'name': { 'type': 'string' },
                        'age': { 'type': 'integer' }
                    },
                    'required': ['name', 'age']
                }";

                JSchema schema = JSchema.Parse(schemaJson);

                string json = "{ \"name\": \"Tushar\", \"age\": 20 }";
                JObject obj = JObject.Parse(json);

                IList<string> errors;
                bool isValid = obj.IsValid(schema, out errors);

                Console.WriteLine($"Is JSON Valid? {isValid}");
                if (!isValid)
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"Validation Error: {error}");
                    }
                }
            }
        }
    }
