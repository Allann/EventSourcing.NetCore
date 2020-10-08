using System;
using Carts.Carts;
using Carts.Tests.Extensions.Reservations;
using Xunit;

namespace Carts.Tests.Carts
{
    public class InitCartTests
    {
        [Fact]
        public void ForValidParams_ShouldCreateCartWithPendingStatus()
        {
            // Given
            var cartId = Guid.NewGuid();
            var clientId = Guid.NewGuid();

            // When
            var cart = Cart.Initialize(
                cartId,
                clientId
            );

            // Then

            cart
                .IsInitializedCartWith(
                    cartId,
                    clientId
                )
                .HasCartInitializedEventWith(
                    cartId,
                    clientId
                );
        }
    }
}
