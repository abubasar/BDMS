
import { BaseRequestModel } from '../base-request-model';
import { BaseService } from '../service/base.service';
import { Entity } from '../entity';
import { ActivatedRoute, Router } from '@angular/router';


export abstract class BaseComponent<T extends Entity>{
  model:T
  
constructor(public service:BaseService<T>,public activatedRoute:ActivatedRoute,public router:Router){
this.model=this.createInstance(Entity) as T;
this.searchRequest=new BaseRequestModel();
this.searchRequest.page=1
this.searchRequest.perPageCount=10
this.searchRequest.orderBy="createdBy"
this.searchRequest.isAscending=false;
}

save(){
  this.service.save(this.model).subscribe(res=>{
    this.reset();
    console.log('success');
  },error=>{
    console.log(error)
  });
}

get(){
  var id=this.activatedRoute.snapshot.params.id;
  this.service.get(id).subscribe(res=>{
    console.log(res);
    this.model=res;

});
}



edit(){
  this.service.edit(this.model).subscribe(res=>{
   // this.router.navigate(['list']);
    this.reset();
    console.log('success');
  },error=>{
    console.log(error)
  });
}

delete(id:number){
  var result=confirm("Are You sure to delete this Market Software");
  if(result){
    this.service.delete(id).subscribe(res=>{
      this.search();
      this.router.navigate(['list'])
    },error=>{
      console.log(error);
    })
  }
    }

abstract reset();

createInstance<Entity>(c:new()=>Entity):Entity{
  return new c();
}
 //query controller start here
 
 models:T[]

searchRequest:BaseRequestModel

search(){
  this.service.search(this.searchRequest).subscribe(res=>{
    this.models=res;
    console.log(this.models);
  },error=>{
    console.log(error)
  })

}
load():void{
  this.service.load(this.searchRequest).subscribe(res=>{
    this.models=res;
    console.log(res)
    });
  }
sort(property:string){
  this.searchRequest.orderBy=property;
  this.searchRequest.isAscending=!this.searchRequest.isAscending  
  this.search();
}

previous(){
if(this.searchRequest.page>1){
this.searchRequest.page=this.searchRequest.page-1; 
this.search();
}
}

next(){
  this.searchRequest.page=this.searchRequest.page+1;
  this.search();

}
}
