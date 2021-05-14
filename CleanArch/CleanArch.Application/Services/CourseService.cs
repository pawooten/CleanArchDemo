using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMediatorHandler _bus;
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this._courseRepository = courseRepository;
            this._bus = bus;
        }

        public void Create( CourseViewModel courseViewModel )
        {
            var createCourseCommand = new CreateCourseCommand( courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl );
            _bus.SendCommand( createCourseCommand );
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses() };
        }
    }
}
