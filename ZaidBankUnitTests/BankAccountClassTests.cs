using System.Runtime.Serialization;
using ZaidBank.Models;
namespace ZaidBankUnitTests;

[TestClass]
public class BankAccountClassTests
{
    [TestMethod]
    [DataRow("AccountNumber", "accNum")]
    public void BankAccountShouldHaveTheCorrectDataMemberNames(string propertyName, string dataMemberName)
    {
        var property = typeof(BankAccount).GetProperty(propertyName);
        var dataMember = property.GetCustomAttributes(typeof(DataMemberAttribute), false).First() as DataMemberAttribute;
        Assert.AreEqual(dataMemberName, dataMember.Name);

        var guid = Guid.NewGuid();

        var date = DateTime.Now;

        Assert.IsNotNull(guid);
    }
}
