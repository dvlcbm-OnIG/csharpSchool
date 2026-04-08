//Instructions:

C# Quiz: Conditionals & Computations
20 Items Quiz 

Note: Make sure to save your code in a notepad save it properly and submit before 9:30 AM

1. Property Discount (double) 
Task: Input totalArea as a double.
Logic: If totalArea > 500, apply a 15% discount to a $1,000 base price.
Formula: discountAmount = 1000 * 0.15.
Output: Use interpolation to show the final price.
2. Fever Alert
Task: Input temp as a float.
Logic: If temp > 38.0, result is "High Fever"; else if temp >= 37.5, result is "Warning"; else, "Normal".
Formula: Evaluate temp > 38.0 then temp >= 37.5.
3. Grading Scale
Task: Input score as an int.
Logic: If score >= 90, grade = 'A'; else if score >= 80, grade = 'B'; else, grade = 'F'.
Formula: Use >= comparison operators.
4. Bulk Order
Task: Input quantity as an int.
Logic: If quantity >= 50, unitPrice = 8; else, unitPrice = 10.
Formula: totalCost = quantity * unitPrice.
Output: $"Total: {totalCost:C}".
5. Security Check
Task: Input password as a string.
Logic: If password.Length < 8, status is "Weak"; else, "Strong".
Formula: Use the property password.Length.
6. Wage Calculation
Task: Input hours as a decimal.
Logic: If hours > 8, calculate overtime.
Formula: pay = (8 * 15) + ((hours - 8) * 20); otherwise, pay = hours * 15.
Output: Use :C for currency formatting.
7. Water States
Task: Input waterTemp as a float.
Logic: If waterTemp <= 0, state is "Solid"; else if waterTemp >= 100, state is "Gas"; else, "Liquid".
Formula: Evaluate multiple else if conditions.
8. Student Discount
Task: Input isStudent as a bool.
Logic: If isStudent is true, discount = 20; otherwise, discount = 0.
Formula: finalPrice = originalPrice - (originalPrice * (discount / 100.0)).
9. Menu Navigation
Task: Input choice as a char.
Logic: If 'S', "Start"; if 'E', "Exit"; else, "Invalid".
Formula: Use == to compare character literals.
10. Speed Fine
Task: Input speed as an int.
Logic: If speed > 100, fine = 500; else if speed > 65, fine = 100; else, fine = 0.
Formula: Determine fine amount based on speed range.