using BusinessObject.Models;
using DataAccess.DAO;

class Program
{
    static void AddProduct()
    {
        ProductDAO productDAO = new ProductDAO();

        productDAO.Create(new Product("Celestial Grace", "Boli Jewery", "Vòng tay này lấy cảm hứng từ vẻ đẹp thanh tao của bầu trời, đây là một sản phẩm thể hiện cho sự thanh bình, hy vọng và tình yêu. Với những chuỗi hạt màu trắng trong hơi đục mang lại sự tinh tế, sang trọng. Rất phù hợp với các cô gái và đặc biệt đây là món quà mà các chàng không thể bỏ qua để thể hiện tình yêu của mình.", 1, 120000, "Trending", "images/product/Celestial Grace.jpg"));
        productDAO.Create(new Product("Blush Harmony", "Boli Jewery", "Đây là một sản phẩm khá đặc biệt với phần lớn thành phần là những sợi dây đan lại với nhau và có một vòng ngọc nhỏ màu đan vào dây. Vòng này là lấy cảm hứng từ những tâm hồn ấm áp, mọng mơ và lãng mạng. Những cô gái theo phong cách nữ tính, nhẹ nhàng rất phù hợp với chiếc vòng này. ", 1, 80000, "Top Trend", "images/product/Blush Harmony.jpg"));
        productDAO.Create(new Product("Lunar Serenity", "Boli Jewery", "Đây là một chiếc vòng mang vẻ đẹp huyền bí của mặt trăng thể hiện sự bí ẩn, quyết rũ của người con gái. Chiếc vòng có những hạt ngọc màu xám đặc biệt mang lại cảm giác sang trọng. Một chiếc vòng thích hợp cho các bữa tiệc.", 1, 140000, "New Arrival", "images/product/Lunar Serenity.jpg"));
        productDAO.Create(new Product("Ethereal Grace", "Boli Jewery", "Các hạt ngọc hình đốt tre kết hợp với vài viên ngọc màu trắng là sự kết hợp hài hoà tạo nên chiếc vòng này. Nó là một chiếc vòng biểu hiện cho sự tao nhã, thanh lịch và thuần khiết. Nó mang một cảm giác nhẹ nhàng tự do.", 1, 160000, "New Arrival", "images/product/Ethereal Grace.jpg"));
        productDAO.Create(new Product("Lush Enchantment", "Boli Jewery", "Những người yêu thích sự tươi tắn, trẻ trung, năng động, cá tính thì đây là sản phẩm bản đang cần, đây là vòng tay với nhiều hạt ngọc nhiều màu sắc lấy cảm hứng từ các thế giới kỳ diệu thể hiện vẻ đẹp tươi tắn, đầy sức sống, hạnh phúc. ", 1, 40000, "New Arrival", "images/product/Lush Enchantment.jpg"));

        productDAO.Create(new Product("Glistening Harmony", "Boli Jewery", "Những ngôi sao lấp lánh, những dòng sông phát sáng lấp dưới anh nắng, những cái cây phát sáng lấp lánh dưới nắng sau trời mưa, bầu đêm đầy sao lấp lánh tạo nên vẻ đẹp hài hoà cho ta cảm giác hạnh phúc, bình yên và vô cùng hài lòng. Chiếc vòng này tượng trưng cho những điều đó nó là một chiếc vòng lấp lánh làm bằng thuỷ tinh trong suốt xâu chuỗi với nhau. ", 1, 300000, "Trending", "images/product/Glistening Harmony.jpg"));
        productDAO.Create(new Product("Whisper of the Aurora", "Boli Jewery", "Chiếc vòng có 4 bông hoa lấp lánh nhiều màu, được lấy cảm hứng từ sự kỳ ảo của vũ trụ, thể hiện sự sáng tạo, linh hoạt. Những cô gái thích một chiếc vòng đơn giản nhưng nổi bật lấp lánh thì đây là chiếc vòng nên có.", 1, 250000, "New Arrival", "images/product/Whisper of the Aurora.jpg"));
        productDAO.Create(new Product("Mystical Melody", "Boli Jewery", "Đây là một vòng được kết hợp giữa hai màu trắng và màu chủ đạo là xanh dương đậm mang lại sự tinh tế sang trong chiếc vòng mang ý nghĩa với sự kết hợp giữa sự mộng mơ, bí ẩn và trầm ổn đây là một giai điệu bay bổng, sâu sắc khó lý giải. Một chiếc vòng cả nam hay nữ đều mang rất đẹp.", 1, 190000, "New Arrival", "images/product/Mystical Melody.jpg"));
        productDAO.Create(new Product("Whispering Elegance", "Boli Jewery", "Đây là một chiếc vòng với nhiều hạt ngọc với các gam màu hơi nhạt, trầm tối mang đên sự thanh lịch, sang trọng nhưng không quá phông trương cầu kì. đây là một sản phẩm cho người theo đuổi phong cách đơn giản.", 1, 130000, "New Arrival", "images/product/Whispering Elegance.jpg"));
        productDAO.Create(new Product("Radiant Dreams", "Boli Jewery", "Những cô gái với phong cách tươi sáng, vủi vẻ rất phù hợp với chiếc vòng này. Chiếc vòng này được sâu bởi những hạt ngọc sáng màu và tươi. Chiếc vòng này mang lại cảm giác rất tích cực và tươi sáng.", 1, 100000, "New Arrival", "images/product/Radiant Dreams.jpg"));

        productDAO.Create(new Product("Dance of the Jade Sea", "Boli Jewery", "Với cảm hứng từ những mẫu trang sức cổ điển, chiếc vòng tay này là sự kết hợp giữa nét đẹp truyền thống và sự sang trọng của thủy tinh. Các hạt thủy tinh được thiết kế với kích thước vừa phải, tạo nên vẻ đẹp trang nhã và thanh lịch, phù hợp với những quý cô yêu thích sự tinh tế và thời trang cổ điển. Có đến bốn màu sắc khắc nhau giúp cho các nàng tha hồ lựa chọn màu sắc mà mình yêu thích", 1, 120000, "Trending", "images/product/Dance of the Jade Sea.jpg"));
        productDAO.Create(new Product("Night Moon Celestial Star", "Boli Jewery", "Với các charm nhỏ được đính kèm trên chuỗi hạt thủy tinh, chiếc vòng này không chỉ đẹp mà còn mang đến sự may mắn và ý nghĩa tinh thần cho người đeo. Món trang sức này là sự lựa chọn hoàn hảo cho những ai yêu thích sự tinh tế và chi tiết.", 1, 220000, "New Arrival", "images/product/Night Moon Celestial Star.jpg"));
        productDAO.Create(new Product("Butterfly Serenade", "Boli Jewery", "Với màu hồng pastel ngọt ngào và lấp lánh, chiếc vòng tay này mang đến vẻ đẹp lãng mạn và nữ tính. Đây là món quà lý tưởng để tặng cho người bạn yêu thương, thể hiện sự quan tâm và tinh tế trong từng chi tiết nhỏ.", 1, 240000, "New Arrival", "images/product/Butterfly Serenade.jpg"));
        productDAO.Create(new Product("Blossom Grace Bracelet", "Boli Jewery", "Sự hòa quyện giữa những hạt thủy tinh sáng bóng và các chi tiết bạc tinh tế tạo nên một chiếc vòng tay đầy quyến rũ. Với độ bền cao và khả năng giữ nguyên vẻ đẹp theo thời gian, chiếc vòng này không chỉ là một món trang sức mà còn là biểu tượng của sự sang trọng và quý phái.", 1, 150000, "Top Trend", "images/product/Blossom Grace Bracelet.jpg"));
        productDAO.Create(new Product("Rose Garden Bracelet", "Boli Jewery", "Vòng đeo tay chuỗi hạt thủy tinh hồng có hoa văn đá hoa cương là sự kết hợp hoàn hảo giữa nét đẹp nhẹ nhàng của sắc hồng và sự mạnh mẽ, độc đáo từ họa tiết đá hoa cương. Mỗi hạt thủy tinh hồng trong chuỗi vòng đều được chế tác tinh xảo, mang đến hiệu ứng trong suốt tuyệt đẹp, kèm theo những đường vân đá hoa cương ấn tượng, tạo nên một món trang sức nổi bật và khác biệt.", 1, 100000, "New Arrival", "images/product/Rose Garden Bracelet.jpg"));

    }
    static void AddUser()
    {
        UserDAO userDAO = new UserDAO();
        userDAO.Create(new User { UserName = "MeoMeo", Email = "Meo@gmail.com", PasswordHash = "123456" });
        userDAO.Create(new User { UserName = "GauGau", Email = "Gau@gmail.com", PasswordHash = "123456" });
    }

    static void Main(string[] args)
    {
        var t = new ProductDAO();
        t.DeleteAll();  
        AddProduct();
    }
}