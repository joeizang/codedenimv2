namespace Codedenim.Domain
{
    public class CourseRating
    {
        public int CourseRatingId { get; set; }
        public int CourseId { get; set; }

        public int Rating { get; set; }
        public int Dislike { get; set; }
        public virtual Course Course { get; set; }

    }
}
