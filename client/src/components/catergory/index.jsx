import React from 'react'
import CategoryIcon from './CategoryIcon'
import FixedNav from './FixedNav'
import {GiAutoRepair,GiReceiveMoney } from 'react-icons/gi';
import {MdLocalShipping} from 'react-icons/md';
const Category = () => {
  return (
    <>
        <div className='grid grid-cols-12 py-[9px] items-center'>
            <div className="col-span-2">
                <FixedNav />
            </div>
            <div className="col-span-10">
                <div className="grid grid-cols-4 gap-2">
                    <a href="client/src/components/catergory/index">
                        <CategoryIcon icon={<GiReceiveMoney className='text-[20px] ' />} label=" Hướng dẫn thanh toán " />
                    </a>
                    <a href="client/src/components/catergory/index">
                        <CategoryIcon icon={<GiReceiveMoney className='text-[20px] ' />}  label=" Hướng dẫn trả góp " />
                    </a>
                    <a href="client/src/components/catergory/index">
                        <CategoryIcon icon={<GiAutoRepair className='text-[20px] ' />} label=" Chính sách bảo hành  " />
                    </a>
                    <a href="client/src/components/catergory/index">
                        <CategoryIcon icon={<MdLocalShipping className='text-[20px] ' />} label=" Chính sách vận chuyển " />
                    </a>
                </div>
            </div>
        </div>
    </>
  )
}

export default Category
