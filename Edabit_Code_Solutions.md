# Return the Next Number from the Integer Passed

fuction addition(num) {
    return num + 1;
}

# Area of a Triangle

function triArea(base, height) {
    return (base * height) / 2;
}

# Convert Age to Days

function calcAge(age) {
    return age * 365;
}

# Return the First Element in an Array

function getFirstValue(arr) {
    return arr[0];
}

# Power Calculator

function circuitPower(voltage, current) {
    return voltage * current;
}

# Convert Hours into Seconds

function howManySeconds(hours) {
    return (hours * 60) * 60;
}

# Maximum Edge of a Triangle

function nextEdge(side1, side2) {
    return (side1 + side2) - 1;
}

#Return the Remainder from Two Numbers

function remainder(x, y) {
    return x % y;
}

# Find the Perimeter of a Rectangle

function findPerimeter(length, width) {
    return (length * 2) + (width * 2);
}

# Return Something to Me!

function giveMeSomething(a) {
    return "something " + a;
}

# Is the Number Less than or Equal to Zero?

function lessThanOrEqualToZero(num) {
    if (num <= 0) {return true;}
    return false;
}

# Sum of Polygon Angles

function sumPolygon(n) {
    return (n - 2) * 180;
}

# Basketball Points

function points(twoPointers, threePointers) {
    return (twoPointers * 2) + (threePointers * 3);
}

# Basic Variable Assignment

function nameString(name) {
    string b = "Edabit";
    return name + b;
}

# Less Than 100?

function lessThan100(a, b) {
    if (a + b < 100) {return true;}
    return false;
}

# The Farm Problem

function animals(chickens, cows, pigs) {
    return (chickens * 2) + (cows * 4) + (pigs * 4);
}

# Are the Numbers Equal?

function isSameNum(num1, num2) {
    if (num1 == num2) {return true;}
    return false;
}

# Football Points

function footballPoints(wins, draws, losses) {
    return (wins * 3) + draws;
}

# Convert Hours and Minutes into Seconds

function convert(hours, minutes) {
    return (hours * 3600) + (minutes * 60);
}

# Profitable Gamble

function profitableGamble(prob, prize, pay) {
    if (prob * prize > pay) {return true;}
    return false;
}

# Boolean to String Conversion 

function boolToString(true) {
    return true.ToString();
}

# Frames Per Second 

function frames(minutes, fps) {
    return (minutes * fps) * 60;
}

# Two Makes Ten

function makesTen(a, b) {
    if (a + b == 10 || a == 10 || b == 10) {return true;}
    return false;
}

# Let's Fuel Up!

function calculateFuel(n) {
    if (n * 10 < 100) { return 100; }
    return n * 10;
}

# Compare Strings by Count of Characters

function comp(str1, str2) {
    if (str1.Length == str2.Length) { return true; }
    return false;
}

# Check if an Integer is Divisible By Five

function divisibleByFive(n) {
    if (n%5 == 0 ) { return true; }
	return false;
}

# Multiple of 100

function divisible(num) {
    if (num%100 == 0 ) { return true; }
	return false;
}

# Recursion: Length of a String

function length(str) {
    return Convert.ToInt32(str.Length);
}

# Divides Evenly

function dividesEvenly(a, b) {
    if (a%b == 0 ) { return true; }
	return false;
}

# Area of a Rectangle

function area(h, w) {
    if (h * w <= 0) { return -1; }
    return h * w;
}

# Concatenate First and Last Name into One String

function concatName(firstName, lastName) {
    return lastName + ", " + firstName;
}