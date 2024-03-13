﻿using Udemy.Domain.Entites;

namespace Udemy.Services.DTOs.BoughtCourses;

public class CreateBoughtCourse
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int CourceId { get; set; }
    public Course Course { get; set; }
}
