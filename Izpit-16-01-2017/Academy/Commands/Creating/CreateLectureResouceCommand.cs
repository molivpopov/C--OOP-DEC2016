﻿using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Creating
{
    public class CreateLectureResouceCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public CreateLectureResouceCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var seasonId = parameters[0];
            var courseId = parameters[1];
            var lectureId = parameters[2];
            var type = parameters[3];
            var name = parameters[4];
            var url = parameters[5];

            var course = this.engine
                .Seasons[int.Parse(seasonId)]
                .Courses[int.Parse(courseId)];

            var lecture = course
                .Lectures[int.Parse(lectureId)];

            var lectureResouce = this.factory.CreateLectureResouce(type, name, url);
            lecture.Resouces.Add(lectureResouce);

            return $"Lecture resource with ID {lecture.Resouces.Count - 1} was created in Lecture {seasonId}.{course.Name}.{lecture.Name}.";
        }
    }
}
