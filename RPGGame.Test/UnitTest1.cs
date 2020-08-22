using RPGGame.Domain.Entity;
using System;
using System.Linq;
using FluentAssertions;
using Xunit;
using Moq;
using RPGGame.Application.Abstract;
using RPGGame.Application.Concrete;
using RPGGame.Application.Managers;
using RPGGame.Domain.Entity.Items;
using Xunit.Abstractions;
namespace RPGGame.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            //Arrange
            Character charc = new Character(1, "Test", 's', 15, 20, 30);
            var mock = new Mock<IService<Character>>(); // Symulacja dzia³ania servisu
            mock.Setup(s => s.GetItemById(1)).Returns(charc);
            var manager =new CreateCharacterManager(new MenuActionService(), mock.Object) ;
            //Act
            var returnetItem = manager.GetItemById(1);
            //Assert
            returnetItem.Should().BeOfType(typeof(Character));
            returnetItem.Should().NotBeNull();
            returnetItem.Should().BeSameAs(charc);

        }
    }
}
