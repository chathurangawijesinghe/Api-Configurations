protoc --proto_path=protos --js_out=library=test-proto,binary:build/gen protos/test.proto

protoc --proto_path=protos --js_out=import_style=commonjs,binary:build/gen protos/test.proto

protoc --proto_path=protos --js_out=import_style=commonjs:$OUT_DIR protos/test.proto

protoc --proto_path=protos --ts_out=import_style=commonjs:$OUT_DIR protos/test.proto




protoc -I=$DIR test.proto \--grpc-web_out=import_style=commonjs,mode=grpcwebtext:$OUT_DIR

protoc --proto_path=protos --grpc-web_out=import_style=commonjs,binary:build/gen protos/test.proto

protoc --proto_path=protos --grpc-web_out=import_style=commonjs,binary:build/gen protos/test.proto


$ protoc -I=$DIR test.proto --js_out=import_style=commonjs:$OUT_DIR --grpc-web_out=import_style=commonjs,mode=grpcwebtext:$OUT_DIR

------------------------------
protoc --plugin=protoc-gen-ts.cmd=./node_modules/.bin/protoc-gen-ts --js_out=import_style=commonjs,binary:./generated --ts_out=./generated src/app/protos/test.proto


protoc --plugin=protoc-gen-ts.cmd=./node_modules/.bin/protoc-gen-ts --js_out=import_style=commonjs,binary:./generated --ts_out=service=grpc-web:./generated src/app/protos/test.proto
