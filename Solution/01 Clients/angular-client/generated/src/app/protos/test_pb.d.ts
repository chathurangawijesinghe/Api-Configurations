// package: test
// file: src/app/protos/test.proto

import * as jspb from "google-protobuf";

export class TestRequest extends jspb.Message {
  getOrderby(): string;
  setOrderby(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): TestRequest.AsObject;
  static toObject(includeInstance: boolean, msg: TestRequest): TestRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: TestRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): TestRequest;
  static deserializeBinaryFromReader(message: TestRequest, reader: jspb.BinaryReader): TestRequest;
}

export namespace TestRequest {
  export type AsObject = {
    orderby: string,
  }
}

export class TestItem extends jspb.Message {
  getId(): number;
  setId(value: number): void;

  getName(): string;
  setName(value: string): void;

  getDefinition(): string;
  setDefinition(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): TestItem.AsObject;
  static toObject(includeInstance: boolean, msg: TestItem): TestItem.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: TestItem, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): TestItem;
  static deserializeBinaryFromReader(message: TestItem, reader: jspb.BinaryReader): TestItem;
}

export namespace TestItem {
  export type AsObject = {
    id: number,
    name: string,
    definition: string,
  }
}

export class Test extends jspb.Message {
  getId(): number;
  setId(value: number): void;

  getName(): string;
  setName(value: string): void;

  getDescription(): string;
  setDescription(value: string): void;

  clearTestitemsList(): void;
  getTestitemsList(): Array<TestItem>;
  setTestitemsList(value: Array<TestItem>): void;
  addTestitems(value?: TestItem, index?: number): TestItem;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Test.AsObject;
  static toObject(includeInstance: boolean, msg: Test): Test.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Test, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Test;
  static deserializeBinaryFromReader(message: Test, reader: jspb.BinaryReader): Test;
}

export namespace Test {
  export type AsObject = {
    id: number,
    name: string,
    description: string,
    testitemsList: Array<TestItem.AsObject>,
  }
}

export class TestReply extends jspb.Message {
  clearTestsList(): void;
  getTestsList(): Array<Test>;
  setTestsList(value: Array<Test>): void;
  addTests(value?: Test, index?: number): Test;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): TestReply.AsObject;
  static toObject(includeInstance: boolean, msg: TestReply): TestReply.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: TestReply, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): TestReply;
  static deserializeBinaryFromReader(message: TestReply, reader: jspb.BinaryReader): TestReply;
}

export namespace TestReply {
  export type AsObject = {
    testsList: Array<Test.AsObject>,
  }
}

