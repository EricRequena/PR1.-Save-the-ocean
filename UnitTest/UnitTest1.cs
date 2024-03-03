using Microsoft.VisualStudio.TestTools.UnitTesting;
using PR1._Save_the_ocean;

namespace SaveTheOceanTests
{
    [TestClass]
    public class TortugaMarinaTests
    {
        [TestMethod]
        public void DescriptionOfAffect_ReturnsCorrectString()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina(1, "11/03/2024", "Tortuga Verde", 50, "Santa Coloma de Gamanet", "Tina", 45);
            string expected = "Tina té un grau d’afectació (GA) del 50%. Vols curar-lo aquí (1) o traslladar-lo al centre (2)?";

            // Act
            string result = tortuga.DescriptionOfAffect();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoRescat_ReturnsCorrectString()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina(1, "11/03/2024", "Tortuga Verde", 50, "Santa Coloma de Gamanet", "Tina", 45);
            string expected = "+-------------------------------------------------------------+\r\n| RESCAT |\r\n+-------------------------------------------------------------+\r\n| # Rescat | Data rescat | Espècie        | GA | Localització |\r\n+-------------------------------------------------------------+\r\n| 001 | 11/03/2024 | Tortuga Marina | 50 | Santa Coloma de Gamanet |\r\n+-------------------------------------------------------------+;";

            // Act
            string result = tortuga.InfoRescat();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFitxa_ReturnsExpectedString()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina(1, "11/03/2024", "Tortuga Verde", 50, "Santa Coloma de Gamanet", "Tina", 45);
            string expected = "+-------------------------------------------------------------+\r\n|                       FITXA                                 |\r\n+-------------------------------------------------------------+\r\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n+-------------------------------------------------------------+\r\n| Tina | Tortuga Marina       | Tortuga Verde | 45            |\r\n+-------------------------------------------------------------+";

            // Act
            string result = tortuga.InfoFitxa();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFinalLaboratory_ReturnsNotNullString()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina(1, "11/03/2024", "Tortuga Verde", 50, "Santa Coloma de Gamanet", "Tina", 45);

            // Act
            string result = tortuga.InfoFinalLaboratory();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InfoFinalCRAM_ReturnsNotNullString()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina(1, "11/03/2024", "Tortuga Verde", 50, "Santa Coloma de Gamanet", "Tina", 45);

            // Act
            string result = tortuga.InfoFinalCRAM();

            // Assert
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    public class CetaciTests
    {
        [TestMethod]
        public void DescriptionOfAffect_ReturnsExpectedString()
        {
            // Arrange
            Cetaci cetaci = new Cetaci(1, "11/03/2024", "Dofi Llistat", 60, "Gavà", "Felix", 225);
            string expected = "Felix té un grau d’afectació (GA) del 60%. Vols curar-lo aquí (1) o traslladar-lo al centre (2)?";

            // Act
            string result = cetaci.DescriptionOfAffect();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoRescat_ReturnsExpectedString()
        {
            // Arrange
            Cetaci cetaci = new Cetaci(1, "11/03/2024", "Dofi Llistat", 60, "Gavà", "Felix", 225);
            string expected = "+-------------------------------------------------------------+\r\n| RESCAT |\r\n+-------------------------------------------------------------+\r\n| # Rescat | Data rescat | Espècie        | GA | Localització |\r\n+-------------------------------------------------------------+\r\n| 001 | 11/03/2024 | Cetaci | 60 | Gavà |\r\n+-------------------------------------------------------------+;";

            // Act
            string result = cetaci.InfoRescat();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFitxa_ReturnsExpectedString()
        {
            // Arrange
            Cetaci cetaci = new Cetaci(1, "11/03/2024", "Dofi Llistat", 60, "Gavà", "Felix", 225);
            string expected = "+-------------------------------------------------------------+\r\n|                       FITXA                                 |\r\n+-------------------------------------------------------------+\r\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n+-------------------------------------------------------------+\r\n| Felix | Cetaci       | Dofi Llistat | 225            |\r\n+-------------------------------------------------------------+";

            // Act
            string result = cetaci.InfoFitxa();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFinalLaboratory_ReturnsNotNullString()
        {
            // Arrange
            Cetaci cetaci = new Cetaci(1, "11/03/2024", "Dofi Llistat", 60, "Gavà", "Felix", 225);

            // Act
            string result = cetaci.InfoFinalLaboratory();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InfoFinalCRAM_ReturnsNotNullString()
        {
            // Arrange
            Cetaci cetaci = new Cetaci(1, "11/03/2024", "Dofi Llistat", 60, "Gavà", "Felix", 225);

            // Act
            string result = cetaci.InfoFinalCRAM();

            // Assert
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    public class AuMarinaTests
    {
        [TestMethod]
        public void DescriptionOfAffect_ReturnsExpectedString()
        {
            // Arrange
            AuMarina auMarina = new AuMarina(1, "11/03/2024", "Au Marina", 70, "Cadaqués", "Richar", 15);
            string expected = "Richar té un grau d’afectació (GA) del 70%. Vols curar-lo aquí (1) o traslladar-lo al centre (2)?";

            // Act
            string result = auMarina.DescriptionOfAffect();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoRescat_ReturnsExpectedString()
        {
            // Arrange
            AuMarina auMarina = new AuMarina(1, "11/03/2024", "Au Marina", 70, "Cadaqués", "Richar", 15);
            string expected = "+-------------------------------------------------------------+\r\n| RESCAT |\r\n+-------------------------------------------------------------+\r\n| # Rescat | Data rescat | Espècie        | GA | Localització |\r\n+-------------------------------------------------------------+\r\n| 001 | 11/03/2024 | Au Marina   | 70 | Cadaqués |\r\n+-------------------------------------------------------------+;";

            // Act
            string result = auMarina.InfoRescat();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFitxa_ReturnsExpectedString()
        {
            // Arrange
            AuMarina auMarina = new AuMarina(1, "11/03/2024", "Au Marina", 70, "Cadaqués", "Richar", 15);
            string expected = "+-------------------------------------------------------------+\r\n|                       FITXA                                 |\r\n+-------------------------------------------------------------+\r\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n+-------------------------------------------------------------+\r\n| Richar | Au Marina       | Au Marina | 15            |\r\n+-------------------------------------------------------------+";

            // Act
            string result = auMarina.InfoFitxa();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InfoFinalLaboratory_ReturnsNotNullString()
        {
            // Arrange
            AuMarina auMarina = new AuMarina(1, "11/03/2024", "Au Marina", 70, "Cadaqués", "Richar", 15);

            // Act
            string result = auMarina.InfoFinalLaboratory();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InfoFinalCRAM_ReturnsNotNullString()
        {
            // Arrange
            AuMarina auMarina = new AuMarina(1, "11/03/2024", "Au Marina", 70, "Cadaqués", "Richar", 15);

            // Act
            string result = auMarina.InfoFinalCRAM();

            // Assert
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    public class VeterinariTests
    {
        [TestMethod]
        public void InfoPerson_ReturnsExpectedString()
        {
            // Arrange
            Veterinari veterinari = new Veterinari("John", 80);
            string expected = "Hola, John! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n";

            // Act
            string result = veterinari.InfoPerson();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TecnicTests
    {
        [TestMethod]
        public void InfoPerson_ReturnsExpectedString()
        {
            // Arrange
            Tecnic tecnic = new Tecnic("Alice", 45);
            string expected = "Hola, Alice! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n";

            // Act
            string result = tecnic.InfoPerson();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
