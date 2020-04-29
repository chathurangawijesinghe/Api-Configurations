import { Component, OnInit, Input } from '@angular/core';
import { getLocaleDateFormat } from '@angular/common';
import { RestService } from '../services/rest.service';
import { GrpcService } from '../services/grpc.service';
import { OdataService } from '../services/odata.service';
import { GraphqlService } from '../services/graphql.service';
import { Test } from '../services/test.model';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
  @Input() clientName: string;

  tests: Test[] = [
    { id: 1, name: 'test client 1', description: 'test client description 1', testItems: [] }
  ];

  constructor(private restService: RestService,
              private odataService: OdataService,
              private graphqlService: GraphqlService,
              private grpcService: GrpcService) { }

  ngOnInit(): void {
    if (this.clientName === 'Rest') {
      this.restService.getData().subscribe((data: Test[]) => {
            this.tests = data;
      });
    } else if (this.clientName === 'OData') {
      this.odataService.getData().subscribe((data) => {
            this.tests = data.value;
      });
    } else if (this.clientName === 'GraphQL') {
      this.graphqlService.getData();
    } else {
      this.grpcService.getData();
    }
  }

}
