using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class CharacterTest
    {
        private Character character;

        [SetUp]
        public void SetUp()
        {
            character = new Character("Player", RaceCategory.Orc, 120);
        }

        [Test]
        public void Character_TakeDamage()
        {
            character.TakeDamage(20);
            Assert.AreEqual(character.Health, 100); 
        }
        [Test]
        public void Character_IsAlive()
        {
            character.TakeDamage(150);
            Assert.IsFalse(character.IsAlive);
        }

        [Test]
        public void Character__RestoreHealth()
        {

        }
    }
}
