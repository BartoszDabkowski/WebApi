namespace WebApi.Tests.Persistence.Repositories
{

    //    [TestClass]
    //    public class PostRepositoryTests
    //    {
    //        private PostRepostiory _repository;
    //        private Mock<DbSet<Post>> _mockPosts;
    //
    //        [TestInitialize]
    //        public void TestInitialize()
    //        {
    //            _mockPosts = new Mock<DbSet<Post>>();
    //
    //            var mockContext = new Mock<IApplicationDbContext>();
    //            mockContext.SetupGet(c => c.Posts).Returns(_mockPosts.Object);
    //
    //            _repository = new PostRepostiory(mockContext.Object);
    //        }
    //
    //        [TestMethod]
    //        public void GetPosts_NoCondition_ShouldBeReturned()
    //        {
    //            var post = new Post()
    //            {
    //                Id = 1,
    //                Title = "Test Title",
    //                Body = "Body",
    //                UserId = "47b28585-f6b5-492d-afe0-873c4e64e5bc",
    //                DateTime = DateTime.Now
    //            };
    //
    //            _mockPosts.SetSource(new[] {post});
    //
    //            var posts = _repository.GetPostsWithUserDetails();
    //
    //            posts.Should().BeEmpty();
    //        }
    //    }
}
