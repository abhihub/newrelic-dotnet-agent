/*
* Copyright 2020 New Relic Corporation. All rights reserved.
* SPDX-License-Identifier: Apache-2.0
*/
namespace NewRelic.OpenTracing.AmazonLambda.Util
{
    public interface IPayload
    {
        string GetPayload { get; }
    }
}
