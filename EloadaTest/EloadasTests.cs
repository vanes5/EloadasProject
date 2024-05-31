using EloadasProject;

namespace EloadasTest
{
    public class EloadasTests
    {

        [Test]
        public void EloadasSorokSzamaNemLehetNulla()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(0, 3); });
        }

        [Test]
        public void EloadasHelyekSzamaNemLehetNulla()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(3, 0); });
        }

        [Test]
        public void EloadasSorokSzamaNemLehetNegativ()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(-2, 3); });
        }
        
        [Test]
        public void EloadasHelyekSzamaNemLehetNegativ()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(3, -4); });
        }

        [Test]
        public void HelyFoglaltSorSzamaNemLehetNulla()
        {
            Eloadas eloadas = new Eloadas(4, 5);
            Assert.Throws<ArgumentException>(() => { eloadas.Foglalt(0, 2); });
        }

        [Test]
        public void HelyFoglaltSorSzamaNemLehetNegativ()
        {
            Eloadas eloadas = new Eloadas(4, 5);
            Assert.Throws<ArgumentException>(() => { eloadas.Foglalt(-2, 2); });
        }

        [Test]
        public void HelyFoglaltHelySzamaNemLehetNulla()
        {
            Eloadas eloadas = new Eloadas(4, 5);
            Assert.Throws<ArgumentException>(() => { eloadas.Foglalt(2, 0); });
        }

        [Test]
        public void HelyFoglaltHelySzamaNemLehetNegativ()
        {
            Eloadas eloadas = new Eloadas(4, 5);
            Assert.Throws<ArgumentException>(() => { eloadas.Foglalt(2, -2); });
        }

        [Test]
        public void EloadasFoglaltMukodik()
        {
            Eloadas eloadas = new Eloadas(4, 5);
            eloadas.Lefoglal();
            Assert.IsTrue(eloadas.Foglalt(1, 1));
        }

        [Test]
        public void EloadasTeliNincsTeleFalseErtek()
        {
            Eloadas eloadas = new Eloadas(4, 5);

            Assert.IsFalse(eloadas.Teli);
        }

        [Test]
        public void EloadasTeliTeleVanTrueErtek()
        {
            Eloadas eloadas = new Eloadas(1, 2);
            eloadas.Lefoglal();
            eloadas.Lefoglal();

            Assert.IsTrue(eloadas.Teli);
        }

        [Test]
        public void SzabadHelyekSzamaMukodikE()
        {
            Eloadas eloadas = new Eloadas(1, 1);

            Assert.That(eloadas.SzabadHelyek, Is.EqualTo(1));
        }


    }

}