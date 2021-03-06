﻿using System;
using NUnit.Framework;

[TestFixture]
public class DifferenceOfSquaresTests
{
    [Test]
    public void Test_square_of_sums_to_5()
    {
        Assert.That(new Squares(5).SquareOfSums(), Is.EqualTo(225));
    }

    [Test]
    public void Test_sum_of_squares_to_5()
    {
        Assert.That(new Squares(5).SumOfSquares(), Is.EqualTo(55));
    }

    [Test]
    public void Test_difference_of_sums_to_5()
    {
        Assert.That(new Squares(5).DifferenceOfSquares(), Is.EqualTo(170));
    }


    [Test]
    public void Test_square_of_sums_to_10()
    {
        Assert.That(new Squares(10).SquareOfSums(), Is.EqualTo(3025));
    }


    [Test]
    public void Test_sum_of_squares_to_10()
    {
        Assert.That(new Squares(10).SumOfSquares(), Is.EqualTo(385));
    }


    [Test]
    public void Test_difference_of_sums_to_10()
    {
        Assert.That(new Squares(10).DifferenceOfSquares(), Is.EqualTo(2640));
    }


    [Test]
    public void Test_square_of_sums_to_100()
    {
        Assert.That(new Squares(100).SquareOfSums(), Is.EqualTo(25502500));
    }


    [Test]
    public void Test_sum_of_squares_to_100()
    {
        Assert.That(new Squares(100).SumOfSquares(), Is.EqualTo(338350));
    }


    [Test]
    public void Test_difference_of_sums_to_100()
    {
        Assert.That(new Squares(100).DifferenceOfSquares(), Is.EqualTo(25164150));
    }


    [Test]
    public void Test_difference_of_sums_0()
    {
        Assert.That(new Squares(0).DifferenceOfSquares(), Is.EqualTo(0));
    }


    [Test]
    public void Test_negative_numbers_throw_argument_exception()
    {
        Assert.That(() => new Squares(-5), Throws.TypeOf<ArgumentException>());
    }
}
