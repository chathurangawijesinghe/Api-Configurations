// package: test
// file: src/app/protos/test.proto

var src_app_protos_test_pb = require("../../../src/app/protos/test_pb");
var grpc = require("@improbable-eng/grpc-web").grpc;

var Tester = (function () {
  function Tester() {}
  Tester.serviceName = "test.Tester";
  return Tester;
}());

Tester.GetTests = {
  methodName: "GetTests",
  service: Tester,
  requestStream: false,
  responseStream: false,
  requestType: src_app_protos_test_pb.TestRequest,
  responseType: src_app_protos_test_pb.TestReply
};

exports.Tester = Tester;

function TesterClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

TesterClient.prototype.getTests = function getTests(requestMessage, metadata, callback) {
  if (arguments.length === 2) {
    callback = arguments[1];
  }
  var client = grpc.unary(Tester.GetTests, {
    request: requestMessage,
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport,
    debug: this.options.debug,
    onEnd: function (response) {
      if (callback) {
        if (response.status !== grpc.Code.OK) {
          var err = new Error(response.statusMessage);
          err.code = response.status;
          err.metadata = response.trailers;
          callback(err, null);
        } else {
          callback(null, response.message);
        }
      }
    }
  });
  return {
    cancel: function () {
      callback = null;
      client.close();
    }
  };
};

exports.TesterClient = TesterClient;

