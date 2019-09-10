<template>
    <div>
        <Modal
         :title="L('CreateNewOperation')"
         :value="value"
         @on-ok="save"
         @on-visible-change="visibleChange"
        >
            <Form ref="operForm"  label-position="top" :rules="operRule" :model="oper">
                <Tabs value="detail">
                    <TabPane :label="L('OperDetails')" name="detail">
                        <FormItem :label="L('Commodity')" prop="commodity">
                            <Input v-model="oper.commodity" :maxlength="32"></Input>
                        </FormItem>
                        <FormItem :label="L('Destiny')" prop="destiny">
                            <Input v-model="oper.destiny" :maxlength="1024"></Input>
                        </FormItem>
                        <FormItem :label="L('Date')" prop="date">
                            <Input v-model="oper.date" type="date"></Input>
                        </FormItem>
                    </TabPane>
                </Tabs>
            </Form>
            <div slot="footer">
                <Button @click="cancel">{{L('Cancel')}}</Button>
                <Button @click="save" type="primary">{{L('OK')}}</Button>
            </div>
        </Modal>
    </div>
</template>

<script lang="ts">
    import { Component, Vue,Inject, Prop,Watch } from 'vue-property-decorator';
    import Util from '../../../lib/util'
    import AbpBase from '../../../lib/abpbase'
    import Operation from '../../../store/entities/operation'
    @Component
    export default class CreateOperation extends AbpBase{
        @Prop({type:Boolean,default:false}) value:boolean;
        oper:Operation=new Operation();

        save(){
        	var today = (new Date()).getTime();
//        	today = today.getTime();

        	var offset = new Date();

        	this.oper.creationTime = new Date(today - 3*60*60*1000 );

/*
        	this.oper.creationTime = 
        	this.oper.creationTime = this.oper.creationTime.getTime();
        	this.oper.creationTime = this.oper.creationTime  (new Date()).getTime() + (new Date()).getTimezoneOffset() );
*/        	

            (this.$refs.operForm as any).validate(async (valid:boolean)=>{
                if(valid){
                    await this.$store.dispatch({
                        type:'operation/create',
                        data:this.oper
                    });
                    (this.$refs.operForm as any).resetFields();
                    this.$emit('save-success');
                    this.$emit('input',false);
                }
            })
        }
        cancel(){
            (this.$refs.operForm as any).resetFields();
            this.$emit('input',false);
        }
        visibleChange(value:boolean){
            if(!value){
                this.$emit('input',value);
            }
        }

        operRule={
            commodity:[{required: true,message:this.L('FieldIsRequired',undefined,this.L('Commodity')),trigger: 'blur'}],
            destiny:[{required:true,message:this.L('FieldIsRequired',undefined,this.L('Destiny')),trigger: 'blur'}],
            date:[{required:true,message:this.L('FieldIsRequired',undefined,this.L('Date')),trigger: 'blur'}],
        }
    }
</script>
