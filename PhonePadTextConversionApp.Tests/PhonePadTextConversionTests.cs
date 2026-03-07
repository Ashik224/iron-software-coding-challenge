using PhonePadTextConversionApp;

namespace PhonePadTextConversionApp.Tests
{
    public class PhonePadTextConversionTests
    {
        [Fact]
        public void OldPhoneTextConverter_ValidInput_ReturnsValidOutput()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "8 88777444666*664#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal("TURING", output);
        }

        [Fact]
        public void OldPhoneTextConverter_EmptyInput_ReturnsEmptyOutput()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteOnEmptyInput_ReturnsEmptyOutput()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "**#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_CheckCyclicEffect_ReturnsExpectedLetter()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "222229999999#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal("BY", output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteMoreThanAvailableTexts_ReturnsEmptyInput()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "2***#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressSameDigitAfterPause_ReturnsSeparateLetters()
        {
            var textConverter = new OldPhonePadTextConversion();
            string input = "44 44#";

            string output = textConverter.OldPhoneTextConverter(input);

            Assert.Equal("HH", output);
        }

    }
}
