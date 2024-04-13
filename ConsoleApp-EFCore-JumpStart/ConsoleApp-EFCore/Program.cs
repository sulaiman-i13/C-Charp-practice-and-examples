#region read list
using (var _context = new AppDbContext())
{
    foreach (var wallet in _context.Wallets)
    {
        Console.WriteLine(wallet);
    }
}
#endregion

#region read one item

//using (var _context = new AppDbContext())
//{
//    var wallet = _context.Wallets.FirstOrDefault(w => w.Id == 1);
//    Console.WriteLine(wallet);
//}

#endregion


#region insert
//using(var _context=new AppDbContext())
//{
//    var wallet = new Wallet
//    {
//        Holder = "Suha",
//        Balance = 10000m
//    };
//    _context.Wallets.Add(wallet);
//    _context.SaveChanges();

//}
#endregion

#region update

//using (var _context = new AppDbContext())
//{
//    var wallet = _context.Wallets.Single(x => x.Id == 1);
//    wallet.Balance += 10000m;
//    _context.Wallets.Update(wallet);
//    _context.SaveChanges();

//}

#endregion

#region delete

//using (var _context = new AppDbContext())
//{
//    var wallet = _context.Wallets.Single(x => x.Id == 1014);

//    _context.Wallets.Remove(wallet);
//    _context.SaveChanges();

//}

#endregion

#region query data

//using (var _context = new AppDbContext())
//{
//    var wallets = _context.Wallets.Where(w=>w.Balance>10000m);

//    foreach (var wallet in wallets)
//    {
//        Console.WriteLine(wallet);
//    }
//    _context.SaveChanges();

//}

#endregion

#region transaction
//using (var _context = new AppDbContext())
//{
//    using (var transaction = _context.Database.BeginTransaction())
//    {
//        try
//        {
//            var walletFrom = _context.Wallets.Single(w => w.Id == 1);
//            var walletTo = _context.Wallets.Single(w => w.Id == 2);
//            walletFrom.Balance -= 10000m;
//            _context.SaveChanges();
//            walletTo.Balance += 10000m;
//            _context.SaveChanges();

//            transaction.Commit();
//        }
//        catch
//        {
//            transaction.Rollback();
//        }
//    }

//}

#endregion
