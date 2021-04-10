select Cars.CarName,Cars.DailyPrice,Brands.BrandName,Colors.ColorName from Cars inner join Brands on Cars.BrandId = Brands.BrandId
inner join Colors on cars.ColorId = Colors.ColorId