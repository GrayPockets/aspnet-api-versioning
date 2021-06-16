﻿namespace Microsoft.Web.Http.Versioning.Conventions
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class OriginalControllerNameConventionTest
    {
        [Fact]
        public void normalize_name_should_trim_suffix()
        {
            // arrange
            var convention = new OriginalControllerNameConvention();

            // act
            var name = convention.NormalizeName( "ValuesController" );

            // assert
            name.Should().Be( "Values" );
        }

        [Theory]
        [InlineData( "Values" )]
        [InlineData( "Values2" )]
        [InlineData( "ValuesController2" )]
        public void normalize_name_should_not_trim_suffix( string controllerName )
        {
            // arrange
            var convention = new OriginalControllerNameConvention();

            // act
            var name = convention.NormalizeName( controllerName );

            // assert
            name.Should().Be( controllerName );
        }

        [Fact]
        public void group_name_should_return_original_name()
        {
            // arrange
            var convention = new OriginalControllerNameConvention();

            // act
            var name = convention.GroupName( "Values2" );

            // assert
            name.Should().Be( "Values2" );
        }
    }
}