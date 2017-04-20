using System;
using BusinessLogic.Implementation;
using DataAccess;
using DataAccess.Repositories;
using DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LogicUnitTest
{
    [TestClass]
    public class CrudUnitTest
    {
        [TestMethod]
        public void GetByIdCheck()
        {
            var id = Guid.NewGuid();
            var mock = new Mock<CrudRepository<IdEntity>>();
            mock.Setup(repo => repo.GetById(id))
                .Returns(new IdEntity {Id = id });

            var logic = new CrudLogic<IdEntity, CrudRepository<IdEntity>>(mock.Object);
            var possitiveResult = logic.GetById(id);
            var negativeResult = logic.GetById(Guid.NewGuid());

            Assert.AreEqual(id, possitiveResult.Id);
            Assert.IsNull(negativeResult);
        }

        [TestMethod]
        public void CreateCheck()
        {
            Guid id = Guid.NewGuid(); //1
            IdEntity item = new IdEntity{Id = id}; //2

            var mock = new Mock<CrudRepository<IdEntity>>();
            mock.Setup(repo => repo.Save(item)); //3
            mock.Setup(repo => repo.GetById(id)).Returns(item); //4

            var logic = new CrudLogic<IdEntity, CrudRepository<IdEntity>>(mock.Object); //5
            logic.Create(item); //6
            var possitiveResult = logic.GetById(item.Id); //7
            var negativeResult = logic.GetById(Guid.NewGuid());

            Assert.AreEqual(id, possitiveResult.Id); //8
            Assert.IsNull(negativeResult);
        }

        [TestMethod]
        public void ExampleMock()
        {
            var mock = new Mock<Random>();
            mock.Setup(repo => repo.GetInt).Returns(12); 

            var random = mock.Object; 
            int i = random.GetInt;
            var r = new Random();

            Assert.AreNotEqual(i, 4);
            Assert.AreEqual(i, 12);
            Assert.AreEqual(r.GetInt, 4);
        }

        public class Random
        {
            public virtual int GetInt => 4;
        }
    }
}
