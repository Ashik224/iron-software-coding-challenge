using PhonePadTextConversionApp;

namespace PhonePadTextConversionApp.Tests
{
    public class PhonePadTextConversionTests
    {
        [Fact]
        public void OldPhoneTextConverter_ValidInput_ReturnsValidOutput()
        {
            string input = "8 88777444666*664#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal("TURING", output);
        }

        [Fact]
        public void OldPhoneTextConverter_EmptyInput_ReturnsEmptyOutput()
        {
            string input = "#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteOnEmptyInput_ReturnsEmptyOutput()
        {
            string input = "**#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_CheckCyclicEffect_ReturnsExpectedLetter()
        {
            string input = "222229999999#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal("BY", output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteMoreThanAvailableTexts_ReturnsEmptyInput()
        {
            string input = "2***#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressSameDigitAfterPause_ReturnsSeparateLetters()
        {
            string input = "44 44#";

            string output = OldPhonePadTextConversion.OldPhoneTextConverter(input);

            Assert.Equal("HH", output);
        }

    }
}
