using MessageDecoder.Console;

namespace MessageDecoder.tests
{
    [TestClass]
    public class CaesarCipherTests
    {
        [TestMethod]
        public void Encode_WithAShiftOfSeven_GeneratesTheExpectedMessage()
        {
            // Arrange.
            var message = "the quick brown fox jumps over the lazy dog";
            var expectedEncodedMessage = "aol xbpjr iyvdu mve qbtwlk vcly aol shgf kvn";
            var cipher = new CaesarChipher(7);

            // Act.
            string actualEncodedMessage = cipher.Encode(message);

            // Assert.
            Assert.AreEqual(expectedEncodedMessage, actualEncodedMessage); 
        }

        [TestMethod]
        public void Decode_WithAShiftOfSeven_ReturnsTheExpectedMessage()
        {
            // Arrange.
            var encodedMessage = "aol xbpjr iyvdu mve qbtwlk vcly aol shgf kvn";
            var expectedDecodedMessage = "the quick brown fox jumps over the lazy dog";
            var cipher = new CaesarChipher(7);

            // Act.
            string actualDecodedMessage = cipher.Decode(encodedMessage);

            // Assert.
            Assert.AreEqual(expectedDecodedMessage, actualDecodedMessage); 
        }

    }
}