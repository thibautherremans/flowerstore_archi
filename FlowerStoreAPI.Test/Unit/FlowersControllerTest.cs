using Xunit;

namespace FlowerStoreAPI.Test.Unit
{

    public class FlowersControllertest
    {   
        FlowersControllertest _controller;
        IFlowerRepo _repo;

        public FlowersControllertest()
        {
            _controller = new FlowersController(_repo);
            _repo = new IFlowerRepo();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.GetAllFlowers();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
