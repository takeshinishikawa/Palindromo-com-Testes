using Palindromo.Model;

namespace TestPalindromo
{
    public class PalindromoTest
    {
        [Theory(DisplayName = "OnlySimpleTextTrue")]
        [InlineData("ANA")]
        [InlineData("ANNA")]
        [InlineData("A A")]

        public void Palindromo_PalindromoOnlySimpleText_ReturnsTrue(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.True(result);
        }

        [Theory(DisplayName = "OnlySimpleTextFalse")]
        [InlineData("AB")]
        [InlineData("BABA")]

        public void Palindromo_PalindromoOnlySimpleText_ReturnsFalse(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.False(result);
        }



        [Theory(DisplayName ="OnlyTextTrue")]
        [InlineData("ROMA ME TEM AMOR")]
        [InlineData("SOCORRAM-ME, SUBI NO ÔNIBUS EM MARROCOS")]
        [InlineData("ME VÊ SE A PANELA DA MOÇA É DE AÇO MADALENA PAES, E VEM")]
        [InlineData("LUZA ROCELINA, A NAMORADA DO MANUEL, LEU NA MODA DA ROMANA: ANIL É COR AZUL")]
        
        public void Palindromo_PalindromoOnlyText_ReturnsTrue(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.True(result);
        }

        [Theory(DisplayName = "OnlyTextFalse")]
        [InlineData("AMAR")]
        [InlineData("TESTE")]

        public void Palindromo_PalindromoOnlyText_ReturnsFalse(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.False(result);
        }

        [Theory(DisplayName = "OnlyTextTrue")]
        [InlineData("Roma me Tem Amor")]
        [InlineData("Socorram-me, subi no ônibus em Marrocos")]
        [InlineData("Me vê se a panela da moça é de aço Madalena Pães, e vem")]
        [InlineData("Luza Rocelina, a namorada do Manuel, leu na moda da romana: anil é cor azul")]

        public void Palindromo_PalindromoOnlyTextLowerAndUpper_ReturnsTrue(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.True(result);
        }

        [Theory(DisplayName = "OnlyTextFalse")]
        [InlineData("Amar")]
        [InlineData("Teste")]

        public void Palindromo_PalindromoOnlyTextLowerAndUpper_ReturnsFalse(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.False(result);
        }

        [Theory(DisplayName = "OnlyNumbersTrue")]
        [InlineData("123321")]
        [InlineData("01233210")]
        public void Palindromo_PalindromoOnlyNumbers_ReturnsTrue(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.True(result);
        }

        [Theory(DisplayName = "OnlyNumbersFalse")]
        [InlineData("123")]
        [InlineData("321")]

        public void Palindromo_PalindromoOnlyNumbers_ReturnsFalse(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.False(result);
        }

        [Theory(DisplayName = "OnlyNumbersAndTextTrue")]
        [InlineData("a1a")]
        [InlineData("a11a")]
        [InlineData("a1-1a")]
        public void Palindromo_PalindromoNumbersAndText_ReturnsTrue(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.True(result);
        }

        [Theory(DisplayName = "OnlyNumbersAndTextFalse")]
        [InlineData("a11")]
        [InlineData("aa1")]
        [InlineData("aa-1")]

        public void Palindromo_PalindromoNumbersAndText_ReturnsFalse(string text)
        {

            var sut = new Palindromos();

            var result = sut.IsPalindromo(text);

            Assert.False(result);
        }
    }
}