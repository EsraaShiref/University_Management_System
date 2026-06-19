using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace University_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CrsId", "Description", "HighestDegree", "LowestDegree", "Name", "Topics" },
                values: new object[,]
                {
                    { 1, "Core concepts of data organization", "A", "D", "Data Structures", "Arrays,Linked Lists,Trees,Graphs" },
                    { 2, "Differential and integral calculus", "A", "D", "Calculus I", "Limits,Derivatives,Integrals" },
                    { 3, "Logic gates and circuit design", "A", "D", "Digital Circuits", "Boolean Algebra,Gates,Flip-Flops" },
                    { 4, "Design and analysis of algorithms", "A", "D", "Algorithms", "Sorting,Searching,Dynamic Programming" },
                    { 5, "Matrices, vectors and linear systems", "A", "D", "Linear Algebra", "Matrices,Vectors,Eigenvalues" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "Location", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Building A, Floor 2", "Computer Science", "555-0101" },
                    { 2, "Building B, Floor 1", "Mathematics", "555-0102" },
                    { 3, "Building C, Floor 3", "Electrical Engineering", "555-0103" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InsId", "Address", "Age", "Degree", "DepartmentId", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "12 Oak Street", 45, "PhD Computer Science", 1, "s.mitchell@uni.edu", "Dr. Sarah Mitchell", 85000m },
                    { 2, "34 Maple Avenue", 52, "PhD Mathematics", 2, "j.okonkwo@uni.edu", "Dr. James Okonkwo", 92000m },
                    { 3, "56 Pine Road", 38, "PhD Electrical Eng.", 3, "l.hoffmann@uni.edu", "Dr. Lena Hoffmann", 78000m },
                    { 4, "78 Cedar Lane", 41, "PhD Computer Science", 1, "o.farouk@uni.edu", "Dr. Omar Farouk", 81000m },
                    { 5, "90 Birch Blvd", 36, "MSc Mathematics", 2, "a.yusuf@uni.edu", "Prof. Amina Yusuf", 74000m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Ahmed Hassan" },
                    { 2, 1, "Sara El-Sayed" },
                    { 3, 2, "Mohamed Ali" },
                    { 4, 3, "Nour Khalil" },
                    { 5, 2, "Youssef Ibrahim" },
                    { 6, 1, "Fatma Mostafa" },
                    { 7, 3, "Omar Adel" },
                    { 8, 2, "Aya Sherif" }
                });

            migrationBuilder.InsertData(
                table: "CourseInstructors",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 2 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "CourseId", "StudentId", "EnrolledOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 6, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CrsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CrsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CrsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CrsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CrsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 3);
        }
    }
}
