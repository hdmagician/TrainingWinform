namespace BookRentalShop20
{
    public static class Commons
    {
        // 공용 연결문자열. static이 들어간 경우 올 대문자로 쓰는 경우가 많다.
        // 얘를 모든 string connstring = 불라불라 를 Commons.CONNSTRING 으로 바꿔준다.
        public static string CONNSTRING =
            "Data Source=192.168.0.26;Initial Catalog=BookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";

        public static string LOGINUSERID = "";
    }
}
