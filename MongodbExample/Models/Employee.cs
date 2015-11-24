using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongodbExample.Models
{
    public partial class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Location { get; set; }
    }

    [BsonIgnoreExtraElements]
    public partial class Employee
    {
        public ObjectId _id { get; set; }
    }
}