import {Store,Module,ActionContext} from 'vuex'
import ListModule from './list-module'
import ListState from './list-state'
import Operation from '../entities/operation'
import Ajax from '../../lib/ajax'
import PageResult from '@/store/entities/page-result';
import ListMutations from './list-mutations'
interface OperationState extends ListState<Operation>{
    editOperation:Operation;
}
class OperationModule extends ListModule<OperationState,any,Operation>{
    state={
        totalCount:0,
        currentPage:1,
        pageSize:10,
        list: new Array<Operation>(),
        loading:false,
        editOperation:new Operation()
    }
    actions={
        async getAll(context:ActionContext<OperationState,any>,payload:any){
            context.state.loading=true;
            let reponse=await Ajax.get('/api/services/app/Operation/All');
            context.state.loading=false;
            let page=reponse.data.result as PageResult<Operation>;
            context.state.totalCount=page.totalCount;
            context.state.list=page.items;
        },
        async create(context:ActionContext<OperationState,any>,payload:any){
            await Ajax.post('/api/services/app/Operation/Create',payload.data);
        },
        async update(context:ActionContext<OperationState,any>,payload:any){
            await Ajax.put('/api/services/app/Operation/Update',payload.data);
        },
        async delete(context:ActionContext<OperationState,any>,payload:any){
            await Ajax.delete('/api/services/app/Operation/Delete?Id='+payload.data.id);
        },
        async get(context:ActionContext<OperationState,any>,payload:any){
            let reponse=await Ajax.get('/api/services/app/Operation/GetOperationById?Id='+payload.id);
            return reponse.data.result as Operation;
        }
    };
    mutations={
        setCurrentPage(state:OperationState,page:number){
            state.currentPage=page;
        },
        setPageSize(state:OperationState,pagesize:number){
            state.pageSize=pagesize;
        },
        edit(state:OperationState,Operation:Operation){
            state.editOperation=Operation;
        }
    }
}
const operationModule=new OperationModule();
export default OperationModule;