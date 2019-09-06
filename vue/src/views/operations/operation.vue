<template>
    <div>
        <Card dis-hover>
            <Button @click="create" icon="android-add" type="primary" size="large">{{L('Add')}}</Button>
        </Card>
        <create-operation v-model="createModalShow"></create-operation>
    </div>
</template>
<script lang="ts">
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';
    import Util from '@/lib/util'
    import AbpBase from '@/lib/abpbase'
    import PageRequest from '@/store/entities/page-request'
    import CreateOperation from './create-operation.vue'

    class PageOperationRequest extends PageRequest {
        keyword: string = '';
        isActive: boolean = null;
    }

    @Component({
        components: { CreateOperation }
    })
    export default class Operations extends AbpBase {
        pagerequest: PageOperationRequest = new PageOperationRequest();

        createModalShow: boolean = false;
        
        create() {
            this.createModalShow = true;
        }
        async getpage(){
            
            this.pagerequest.maxResultCount=this.pageSize;
            this.pagerequest.skipCount=(this.currentPage-1)*this.pageSize;
            
            await this.$store.dispatch({
                type:'operation/All',
                data:this.pagerequest
            })
        }

        columns=[{
            title:this.L('Date'),
            key:'date'
        },{
            title:this.L('Commodity'),
            key:'commodity'
        },{
            title:this.L('Destiny'),
            key:'destiny'
        }/*,{
            title:this.L('Actions'),
            key:'Actions',
            width:150,
            render:(h:any,params:any)=>{
                return h('div',[
                    h('Button',{
                        props:{
                            type:'primary',
                            size:'small'
                        },
                        style:{
                            marginRight:'5px'
                        },
                        on:{
                            click:()=>{
                                this.$store.commit('tenant/edit',params.row);
                                this.edit();
                            }
                        }
                    },this.L('Edit')),
                    h('Button',{
                        props:{
                            type:'error',
                            size:'small'
                        },
                        on:{
                            click:async ()=>{
                                this.$Modal.confirm({
                                        title:this.L('Tips'),
                                        content:this.L('DeleteTenantConfirm'),
                                        okText:this.L('Yes'),
                                        cancelText:this.L('No'),
                                        onOk:async()=>{
                                            await this.$store.dispatch({
                                                type:'tenant/delete',
                                                data:params.row
                                            })
                                            await this.getpage();
                                        }
                                })
                            }
                        }
                    },this.L('Delete'))
                ])
            }
        }*/]
        async created(){
            this.getpage();
        }
    }
</script>