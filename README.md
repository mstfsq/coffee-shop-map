Includes:

 Display a welcome message to the user, giving the name of your coffee shop and logo

Ask the user for their personal details for delivery

Display a menu of products to the user The menu needs to include the product name the for
coffee the product description and unit price as a minimum
 
Prompt the user for the product quantity
 
Calculate the total cost of the order
 
Ask the user how much they would like to pay
 
Calculate their change
 
Present the user with a receipt of their order

Add VAT to the Total Bill being 20 % using a constant
 Add to the users receipt the customer’s name in the format MR ZMORAN (Zeon Moran) all
uppercase or lowercase.
 On the receipt give the user an account reference number being ZMORAN2709 Format of
1st letter of first name, concatenate last name, concatenate 2 digits for day of birth and 2
digits for month of birth. All must be displayed in either upper case or lower case.
 Display total cost formatted to currency
 When a user completes an order, the system asks if there is another customer order to be
processed if the answer is yes the program loops and allows for another order to be taken
 Security when the program loads and displays the welcome message the user is asked to
enter the master password. They will only be able to proceed to the main menu if they enter
your master password, otherwise the system will display incorrect password and ask for the
master password to be re-entered.
 The system needs to be robust and be able to handle erroneous/invalid data. Integrate
validation into the system to handle the following:
o A Presence Check (no blank data eg first name cannot be blank/null)
o A Range Check (a value must be entered between an upper a lower limit e.g.quantity between 1 and 10)
o A lookup/list check (a user can only enter from a list of acceptable values e.g.
customer title Mr, Ms, Miss, Dr or a Menu Code from the list presented only)
o A Length check (A customer first name cannot exceed 20 characters)

