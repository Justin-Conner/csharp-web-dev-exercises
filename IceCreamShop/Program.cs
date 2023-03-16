using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
//FlavorComparer comparer = new FlavorComparer();
foreach (Flavor flavor in availableFlavors)
{
    Console.WriteLine($"{flavor.Name}Allergens: {flavor.Allergens.Count}");
}
availableFlavors.Sort(new FlavorComparer());

foreach (Flavor flav in availableFlavors) { 
Console.WriteLine(flav.Name);
}


// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
foreach (Cone con in availableCones)
{
    Console.WriteLine(con.Cost);
}
availableCones.Sort(new ConeComparer());


// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
