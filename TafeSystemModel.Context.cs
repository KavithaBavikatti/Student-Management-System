﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAFESystem1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentDBEntities : DbContext
    {
        public StudentDBEntities()
            : base("name=StudentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cluster> Clusters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseClusterUnit> CourseClusterUnits { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentEnrolment> StudentEnrolments { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherEnrolment> TeacherEnrolments { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<vw_StudentDetails> vw_StudentDetails { get; set; }
        public virtual DbSet<vw_TeacherDetails> vw_TeacherDetails { get; set; }
    
        public virtual int SP_InsertCourseCluster(Nullable<int> courseId, Nullable<int> clusterId)
        {
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            var clusterIdParameter = clusterId.HasValue ?
                new ObjectParameter("ClusterId", clusterId) :
                new ObjectParameter("ClusterId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCourseCluster", courseIdParameter, clusterIdParameter);
        }
    
        public virtual int SP_InsertCourseLocation(Nullable<int> courseId, Nullable<int> locationId)
        {
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCourseLocation", courseIdParameter, locationIdParameter);
        }
    
        public virtual int SP_InsertCourseSemester(Nullable<int> courseId, Nullable<int> semesterId)
        {
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            var semesterIdParameter = semesterId.HasValue ?
                new ObjectParameter("SemesterId", semesterId) :
                new ObjectParameter("SemesterId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCourseSemester", courseIdParameter, semesterIdParameter);
        }
    }
}
