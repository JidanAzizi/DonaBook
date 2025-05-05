using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DonasiBukuTests
{
    [TestClass]
    public class LayananDonasiBukuTests
    {
        public LayananDonasiBuku layanan;

        [TestInitialize]
        public void Setup()
        {
            layanan = new LayananDonasiBuku();
        }

        [TestMethod]
        public void ValidasiBahasa_ValidInputId_ReturnsId()
        {
            var result = layanan.ValidasiBahasa("id");
            Assert.AreEqual("id", result);
        }

        [TestMethod]
        public void ValidasiBahasa_ValidInputEn_ReturnsEn()
        {
            var result = layanan.ValidasiBahasa(" en ");
            Assert.AreEqual("en", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidasiBahasa_InvalidInput_ThrowsException()
        {
            layanan.ValidasiBahasa("fr");
        }

        [TestMethod]
        public void ValidasiPeran_ValidDonorEn_ReturnsTrue()
        {
            var result = layanan.ValidasiPeran("en", "donor");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidasiPeran_ValidRelawanId_ReturnsTrue()
        {
            var result = layanan.ValidasiPeran("id", "relawan");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidasiPeran_InvalidPeran_ReturnsFalse()
        {
            var result = layanan.ValidasiPeran("en", "donattor");
            Assert.IsFalse(result);
        }
    }
}
