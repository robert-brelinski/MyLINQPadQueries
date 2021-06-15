<Query Kind="Statements" />

int cardNumber = 12;

string cardName = cardNumber switch
{
	13 => "King",
	12 => "Queen",
	_ => "Other"
};

cardName.Dump();

int cardNum = 12;
string suite = "spades";

string cardName2 = (cardNum, suite) switch
{
	(12, "spades") => "King of spdaes",
	(13, "clubs") => "King of clubs"
};

cardName2.Dump();