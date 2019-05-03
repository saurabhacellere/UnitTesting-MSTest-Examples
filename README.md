# UnitTesting-MSTest-Examples #
<a target="_blank" href="LICENSE"><img src="https://img.shields.io/badge/licence-MIT-brightgreen.svg" alt="license : MIT"></a>
<a target="_blank" href="https://www.nuget.org/packages/MSTest.TestFramework"><img src="https://img.shields.io/badge/nuget-mstest-yellowgreen.svg" alt="MSTest.TestFramework"></a>

## What is Unit Testing? ##
It tests behavior of a function/method by writing another piece of code.

## Why Unit Tests? ##

Normally, software projects are intended to run for long-term, at least for a minimum of five years. During this period, maintaining the application is very crucial. Any change request received might impact the other functionality of the application. So, before deploying the change in the production, a lot of regression testing has to be done. This consumes a lot of tester’s time.

Read more on <a target="_blank" href="https://www.cmarix.com/importance-of-unit-testing-in-software-development/">Importance Of Unit Testing In Software Development</a>

## Benefits of Unit Tests ##

1. Reduce the Number of Bugs
2. Easily Change and Refactor Code
3. Automated Tests
4. Improve Code design

## Unit Tests frameworks in C# ##

1. MS Test
2. NUnit

## AAA - Unit Tests Pattern ##
![AAA Pattern](https://www.cmarix.com/git/DotNet/UnitTesting-MSTest-AAAPattern.jpg)

1.	**Arrange** all the necessary preconditions and inputs.

		// Arrange 
		Employee employee = new Employee();	
		string firstName = "Peter";
		string lastName = "Bravo";
		string expected = "Peter Bravo";
		string actual;

2.	**Act** on the object or method under test.

		// Act  
		actual = employee.GetName(firstName, lastName);

3.	**Assert** that the expected results have occurred.

		// Assert  
		Assert.AreEqual(expected, actual);


## Result ##
![MSTest RunTest](https://www.cmarix.com/git/DotNet/UnitTesting-MSTest-RunTest.png)


## Let us know! ##
We’d be really happy if you sent us links to your projects where you use our component. Just send an email to [biz@cmarix.com](mailto:biz@cmarix.com "biz@cmarix.com") and do let us know if you have any questions or suggestion regarding unit testing in c#.

P.S. We’re going to publish more awesomeness examples on third party libraries, coding standards, plugins etc, in all the technology. Stay tuned!

## Stay Socially Connected ##

Get more familiar with our work by visiting few of our portfolio links.

[Portfolio](https://www.cmarix.com/portfolio.html) | [Facebook](https://www.facebook.com/CMARIXTechnoLabs/) | [Twitter](https://twitter.com/CMARIXTechLabs) | [Linkedin](https://www.linkedin.com/company/cmarix-technolabs-pvt-ltd-) | [Behance](https://www.behance.net/CMARIXTechnoLabs/) | [Instagram](https://instagram.com/cmarixtechnolabs/) | [Dribbble](https://dribbble.com/CMARIXTechnoLabs) | [Uplabs](https://www.uplabs.com/cmarixtechnolabs)

Please don’t forget to follow them.

## License ##

	MIT License
	
	Copyright © 2019 CMARIX TechnoLabs
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:
	
	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.
	
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
