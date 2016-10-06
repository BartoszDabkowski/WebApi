namespace WebApi.Tests.Controllers.Api
{
    //    [TestClass]
    //    public class PostsControllerTests
    //    {
    //        private PostsController _controller;
    //        private Mock<IPostRepository> _mockRepository;
    //        private string _userId;
    //        private string _username;
    //
    //        [TestInitialize]
    //        public void TestInitialize()
    //        {
    //            _mockRepository = new Mock<IPostRepository>();
    //
    //            var mockUnitOfWork = new Mock<IUnitOfWork>();
    //            mockUnitOfWork.SetupGet(u => u.Posts).Returns(_mockRepository.Object);
    //
    //            _controller = new PostsController(mockUnitOfWork.Object);
    //            _userId = "1";
    //            _username = "user1@pinkerton.com";
    //
    //            _controller.MockCurrentUser(_userId, _username);
    //        }
    //
    //        [TestMethod]
    //        public void GetPosts_NoPostWithGivenIdExists_ShouldReturnNotFound()
    //        {
    //            var result = _controller.GetComment(1, 1);
    //
    //            result.Should().BeOfType<NotFoundResult>();
    //        }
    //    }
}
