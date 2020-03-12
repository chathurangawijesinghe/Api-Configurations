export class Test {
  id: number;
  name: string;
  description: string;
  testItems: [];

  constructor(id, name, description) {
    this.id = id;
    this.name = name;
    this.description = description;
  }
}
