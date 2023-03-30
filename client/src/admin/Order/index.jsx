import React from 'react'
import Navbar from '../Navbar';
import NavbarTop from '../NavbarTop';
import { Link } from 'react-router-dom';
import { useEffect, useState } from 'react'
import { getOrderApi } from '../../app/services/orderService';
import ModalOrder from './Modal/ModalOrder';
import { AiFillEye } from 'react-icons/ai'
import moment from 'moment/moment';

const Order = () => {

  const [dataOrder, setDataOrder] = useState([]);

  const [open, setOpen] = useState(false);

  const [orderView, setOrderView] = useState({})

  console.log(dataOrder);

  useEffect(() => {
    const getAllOrder = async () => {
      try {
        const res = await getOrderApi();
        setDataOrder(res.data);
      } catch (error) {
        console.log(error.message);
      }
    }
    getAllOrder();
  }, []);

  const handleClickOrder = (data) => {
    setOrderView(data)
    setOpen(true)
    console.log(data);
  }

  return (
    <>
      <div className="bg-[#eceff1] min-h-[1070px]">
        <div className="grid grid-cols-12  ">
          <ModalOrder orderView={orderView} open={open} onClose={() => setOpen(false)} />
          <div className="col-span-2">
            <Navbar />
          </div>
          <div className="col-span-10">
            <div className="mt-5"><NavbarTop /></div>
            <div className="relative flex flex-col bg-clip-border rounded-xl bg-white text-gray-700 shadow-md mt-12 mb-8  gap-12">
              <div className="relative flex justify-between bg-clip-border mx-4 rounded-xl overflow-hidden bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-blue-500/40 shadow-lg -mt-6  p-6">
                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Order</h6>
              </div>
              <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                <table className='w-full min-w-[640px] table-auto'>
                  <thead>
                    <tr>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Ngày</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Tên </p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Email</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Số điện thoại</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Địa chỉ</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Thành phố</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {dataOrder.map((item, index) => {
                      return (
                        <tr key={index}>
                          <td className='py-3 px-5'>{moment(item.orderDate).format()}</td>
                          <td className='py-3 px-5 '>{item.user.fullName}</td>
                          <td className='py-3 px-5 '>{item.user.email}</td>
                          <td className='py-3 px-5 '>{item.user.phone}</td>
                          <td className='py-3 px-5 '>{item.address}</td>
                          <td className='py-3 px-5 '>{item.city}</td>
                          <td className='py-3 px-5 ' onClick={(e) => handleClickOrder(item)}>
                            <AiFillEye className='text-[20px] cursor-pointer text-yellow-500' />
                          </td>
                        </tr>
                      );
                    })}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  )
}

export default Order