import React, { useContext } from 'react'
import Category from '../catergory'
import Header from '../Header'
import { AuthContext } from '../../contexts/AuthProvider';


const PayProduct = () => {
    const { auth } = useContext(AuthContext);
    return (
        <>
            <div className='bg-[#f1f0f1]'>
                <Header />
                <Category />
            </div>
            <div className="bg-[#F8F8FC] h-[830px]">
                <div className="container mx-auto">
                    <div className="rounded-[1rem] gap-6 grid grid-cols-12">
                        <div className="mt-[15px] col-span-8 rounded-[8px] py-[4vh] px-[5vh] bg-[#FFFFFF]  ">
                            <div className="w-full mb-5">
                                <div className="relative">
                                    <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Họ và tên</label>
                                    <input value={auth.fullName} className="border-[1px] outline-[#338dbc] outline-[1px] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                </div>
                            </div>
                            <div className="w-full mb-5">
                                <div className="relative">
                                    <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Số điện thoại</label>
                                    <input value={auth.phone} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                </div>
                            </div>
                            <div className="w-full mb-5">
                                <div className="relative">
                                    <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Email</label>
                                    <input value={auth.email} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                </div>
                            </div>
                            <div className="w-full mb-5">
                                <div className="relative">
                                    <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Địa chỉ</label>
                                    <input className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                </div>
                            </div>
                        </div>
                        <div className="col-span-4 mt-[15px]">
                            <div className="bg-[#FFFFFF] rounded-[8px] ">
                                mai
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default PayProduct