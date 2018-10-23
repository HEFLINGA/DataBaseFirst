using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoSite.Models
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
    }

    [MetadataType(typeof(EnrollmentMetaData))]
    public partial class Enrollment
    {
    }
}