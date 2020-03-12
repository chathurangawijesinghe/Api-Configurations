import { Injectable } from '@angular/core';

import * as proto from '../../../generated/src/app/protos/test_pb';

import {grpc} from '@improbable-eng/grpc-web';
import { TesterClient, Tester } from '../../../generated/src/app/protos/test_pb_service';
import {TestRequest, TestReply, Test} from '../../../generated/src/app/protos/test_pb';

@Injectable({
  providedIn: 'root'
})
export class GrpcService {
  constructor() { }

  tests = [];

  test = new TestRequest();

  getData() {
    grpc.unary(Tester.GetTests, {
      request: this.test,
      host: 'https://localhost:5001',
      onEnd: res => {
        const { status, statusMessage, headers, message, trailers } = res;
        if (status === grpc.Code.OK && message) {
        const result = message.toObject() as TestReply.AsObject;
        }
      }
    });
  }

  getTests() {
  }
}
