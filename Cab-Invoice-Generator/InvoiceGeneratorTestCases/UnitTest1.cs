namespace InvoiceGeneratorTestCases
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTimeCalculateAndReturnTotalFare()
        {
            double distance = 2, time = 5, expected = 25;
            Cab_Invoice_Generator.InvoiceGenerator generate = new Cab_Invoice_Generator.InvoiceGenerator();
            double result = generate.calculateNormalFare(distance, time);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GivenLessDistanceOrTimeShouldReturnMinimumFare()
        {
            Cab_Invoice_Generator.InvoiceGenerator generate = new Cab_Invoice_Generator.InvoiceGenerator();
            double distance = 0.1, time = 1, expected = 5;
            double result = generate.calculateNormalFare(distance, time);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GivenDistanceAndTimeCalculateAndReturnPremiumFare()
        {
            double distance = 2, time = 5, expected = 40;
            Cab_Invoice_Generator.InvoiceGenerator generate = new Cab_Invoice_Generator.InvoiceGenerator();
            double result = generate.calculatePremiumFare(distance, time);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GivenLessDistanceOrTimeShouldReturnMinimumPremiumFare()
        {
            Cab_Invoice_Generator.InvoiceGenerator generate = new Cab_Invoice_Generator.InvoiceGenerator();
            double distance = 0.1, time = 1, expected = 20;
            double result = generate.calculatePremiumFare(distance, time);
            Assert.AreEqual(expected, result);
        }
    }
}