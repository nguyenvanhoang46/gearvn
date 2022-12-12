import React from 'react'
import Button from '../Button'
import {BsFillTelephoneFill} from 'react-icons/bs';
import {AiFillYoutube} from 'react-icons/ai';
import {GrTechnology} from 'react-icons/gr';
const InfoTop = () => {
  return (
    <>
    <div className='flex mr-[20px] mt-2'>
        {/* <Button label="Tổng đài" icon={<BsFillTelephoneFill /> } />
        <Button label="Video" icon={<AiFillYoutube /> } />
        <Button label="Tin công nghệ" icon={<GrTechnology /> } />
        <Button label="Tuyển dụng" icon={<BsFillTelephoneFill /> } />
        <Button label="Hệ thống Showroom" icon={<BsFillTelephoneFill /> } /> */}
        <ul className='flex ml-5 '>
            <li className='flex mr-[20px] h-[20px] pr-[20px] items-center text-[#ea1c00] font-bold uppercase border-r-2 border-[#ea1c00] '>
                <img className='w-[18px] '  src="//theme.hstatic.net/1000026716/1000440777/14/tongdai-icon.png?v=30376" />
                <span className='ml-[10px] '>
                   <a href="" className='text-sm'>Tổng đài</a>
                </span>
            </li>
            <li className='flex h-[20px] flex mr-[20px] h-[20px] pr-[20px] items-center text-[#ea1c00] font-bold uppercase border-r-2 border-[#ea1c00] '>
                <img className='w-[18px] mr-[10px] ' src="//theme.hstatic.net/1000026716/1000440777/14/youtube.png?v=30376" />
                <span>
                   <a href="" className='text-sm'>videos</a>
                </span>
            </li>
            <li className='flex h-[20px] flex mr-[20px] h-[20px] pr-[20px] items-center text-[#ea1c00] font-bold uppercase border-r-2 border-[#ea1c00] '>
                <img className='w-[18px] mr-[10px]' src="//theme.hstatic.net/1000026716/1000440777/14/gNewsFavIco.png?v=30376" />
                <span>
                   <a href="" className='text-sm'>Tin công nghệ</a>
                </span>
            </li>
            <li className='flex h-[20px] flex mr-[20px] h-[20px] pr-[20px] items-center text-[#ea1c00] font-bold uppercase border-r-2 border-[#ea1c00] '>
                <img className='w-[18px] mr-[10px]' src="//theme.hstatic.net/1000026716/1000440777/14/logo_hr.png?v=30376"/>
                <span>
                   <a href="" className='text-sm'>Tuyển dụng</a>
                </span>
            </li>
            <li className='flex h-[20px] flex mr-[20px] h-[20px] pr-[20px] items-center text-[#ea1c00] font-bold uppercase'>
                <img className='w-[18px] mr-[10px]' src="https://file.hstatic.net/200000397757/file/car-dealer_97df9ccd23f243e3a4da757eb19afe6c.png" />
                <span>
                   <a href="" className='text-sm'>Hệ thống Showroom</a>
                </span>
            </li>
        </ul>
    </div>
    </>
  )
}

export default InfoTop
