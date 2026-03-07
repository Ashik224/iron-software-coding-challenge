using PhonePadTextConversionApp;

namespace PhonePadTextConversionApp.Tests
{
    public class PhonePadTextConversionTests
    {
        [Fact]
        public void OldPhoneTextConverter_ValidInput_ReturnsValidOutput()
        {
            string input = "8 88777444666*664#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("TURING", output);
        }

        [Fact]
        public void OldPhoneTextConverter_EmptyInput_ReturnsEmptyOutput()
        {
            string input = "#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteOnEmptyInput_ReturnsEmptyOutput()
        {
            string input = "**#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_CheckCyclicEffect_ReturnsExpectedLetters()
        {
            string input = "222229999999#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("BY", output);
        }

        [Fact]
        public void OldPhoneTextConverter_DeleteMoreThanAvailableTexts_ReturnsEmptyInput()
        {
            string input = "2***#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal(String.Empty, output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressSameDigitAfterPause_ReturnsSeparateLetters()
        {
            string input = "44 44#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("HH", output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressFourAlphabetDigits_ReturnsExpectedLetters()
        {
            string input = "99997777#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("ZS", output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressDifferentDigitsAfterPause_ReturnsExpectedLetters()
        {
            string input = "33 555 76#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("ELPM", output);
        }

        [Fact]
        public void OldPhoneTextConverter_PressLastTwoDigits_ReturnsExpectedLetters()
        {
            string input = "88999#";

            string output = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput(input);

            Assert.Equal("UY", output);
        }
    }
}
