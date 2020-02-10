namespace BusinessEntities
{
    interface IUser
    {
        string Adress { get; set; }
        string Email { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Password { get; set; }
        string PhoneNr { get; set; }
        string UserId { get; set; }
    }
}