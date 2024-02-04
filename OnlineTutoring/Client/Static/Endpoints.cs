using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace OnlineTutoring.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string TutorsEndpoint = $"{Prefix}/tutors";
        public static readonly string SubjectsEndpoint = $"{Prefix}/subjects";
        public static readonly string StudentsEndpoint = $"{Prefix}/students";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string QualificationsEndpoint = $"{Prefix}/qualifications";
        public static readonly string PostersEndpoint = $"{Prefix}/posters";
        public static readonly string GendersEndpoint = $"{Prefix}/genders";
        public static readonly string DegreesEndpoint = $"{Prefix}/degrees";
        public static readonly string DiplomasEndpoint = $"{Prefix}/diplomas";
        public static readonly string MessagesEndpoint = $"{Prefix}/messages";
        public static readonly string AppointmentsEndpoint = $"{Prefix}/appointments";
    }
}
