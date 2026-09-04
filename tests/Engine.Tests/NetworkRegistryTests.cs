using Backtest.Engine.Networks;
using Xunit;

namespace Backtest.Engine.Tests;

public class NetworkRegistryTests
{
    [Fact]
    public void GetNetwork_ReturnsEthereumDescriptor()
    {
        var registry = new NetworkRegistry();
        var network = registry.GetNetwork("ethereum-mainnet");

        Assert.Equal("ETH", network.NativeAssetSymbol);
        Assert.Equal("evm", network.ChainType);
    }

    [Fact]
    public void GetAllNetworks_ReturnsAtLeastFourNetworks()
    {
        var registry = new NetworkRegistry();
        Assert.True(registry.GetAllNetworks().Count >= 4);
    }
}
